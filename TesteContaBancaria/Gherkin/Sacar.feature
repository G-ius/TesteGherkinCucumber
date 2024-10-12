Feature: Sacar
    Como usuário, eu quero sacar dinheiro da minha conta bancária se houver saldo disponivel, para que eu possa utilizar o dinheiro em espécie.

Scenario: Saque
    Given o saldo da conta é de 10000
    When o usuário solicitar um saque de 5000
    Then o saldo da conta será de 5000

Scenario: Unsaque
	Given o saldo da conta é de 0
	When o usuário solicitar um saque de 5000
	Then a mensagem Saldo insuficiente! será exibida