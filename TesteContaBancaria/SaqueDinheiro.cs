using Xunit.Gherkin.Quick;
using Xunit;
using GerenciadorDeFinancias.Models;

namespace TesteContaBancaria
{
    [FeatureFile("./Gherkin/Sacar.feature")]
    public sealed class SaqueDinheiro : Feature
    {
        private readonly ContaBancaria _bankAccount = new ContaBancaria();
        string retorno = "";
        //Implementa
        [Given(@"o saldo da conta � de (\d+)")]
        public void Given_the_first_number_is(int saldo)
        {
            _bankAccount.Saldo = saldo;
        }

        [When(@"o usu�rio solicitar um saque de (\d+)")]
        public void When_the_second_number_is(int valor)
        {
            retorno = _bankAccount.Sacar(valor);
        }

        [Then(@"o saldo da conta ser� de (\d+)")]
        public void Then_the_result_should_be(int saldo)
        {
            Assert.Equal(saldo, _bankAccount.Saldo);
        }

        [Then(@"a mensagem (""""Saldo insuficiente!"""") ser� exibida")]
        public void Then_the_result_will_be(string  ms)
        {
            Assert.Equal(ms,retorno);
        }
    }
}