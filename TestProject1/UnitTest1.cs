using AulaMVC.Models;
using AulaMVC.Repositories;
using AulaMVC.Services;
using Moq;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void FindReturnsNullWhenIdIsNull()
        {
            Moq.Mock<IClienteRepository> mockClienteRepository = new Moq.Mock<IClienteRepository>();
            //mockClienteRepository.Setup(mock => mock.Get(It.IsAny<int>())).Returns(value: null);
            ClienteService clienteService = new ClienteService(mockClienteRepository.Object);

            var cliente = clienteService.Find(null);

            Assert.Null(cliente);

        }

        [Fact]
        public void UserIsCreatedWithUpperCaseName()
        {
            Moq.Mock<IClienteRepository> mockClienteRepository = new Moq.Mock<IClienteRepository>();
            mockClienteRepository.Setup(x => x.Create(It.IsAny<Cliente>())).Returns<Cliente>(x => x);
            ClienteService clienteService = new ClienteService(mockClienteRepository.Object);

            var cliente = new Cliente()
            {
                Id = 0,
                Nome = "Vinicius Alves Fernandes",
                Email = "v@1500fh.com",
                Idade = 23,
                Salario = 21331313221
            };

            var createdCliente = clienteService.Create(cliente);
            var upperName = cliente.Nome.ToUpper();
            Assert.NotNull(createdCliente);
            Assert.Equal(upperName, createdCliente.Nome);

        }
    }
}