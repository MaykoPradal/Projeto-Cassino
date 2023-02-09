# Projeto-Cassino

















Este é um projeto feito em C# usando o visual studio community, guiado e mentorado pelo profª Bruno Santos ( https://www.youtube.com/@brunofrs7 ).
se trata de uma aplicação de jogos que possuem dois jogos e um deles possue uma vertente.
possui um "cadastro" de usuario com carteira de saldo em R$ ao qual ja se inicia com R$100,00. E um sistema de depósitos e saques para criar uma imersão nos jogos.
===============================================================================
LOTERIA: A loteria tem um custo de R$5,00 do saldo do usuario por jogo, onde o usuario precisa inserir um valor de 1000 a 9999 para validar a jogada.
os números a serem sorteados e o valor do prêmio é gerado aleatóriamente pelo sistema.
para ser contemplado o usuário precisa acertar 4 digitos, 2 digitos ou 1 digito do numero sorteado.
acertando os 4 digitos o usuario ganha o 1ª prêmio que equivale a 100% do valor do prêmio que tambêm é gerado aleatóriamente pelo sistema no valor de 1000 a 10000.
acertando 2 digitos o usuario ganha o 2ª prêmio que equivale a 50% do valor gerado pelo sistema, e acertando 1 digito o usuario ganha o 3ª prêmio que equivale a 20% do valor gerado pelo sistema.
se o usuário for contemplado o valor ganho soma ao saldo do mesmo.
===============================================================================
RASPADINHA A: A Raspadinha de tipo A tem um custo de R$2,00 por jogo, possui um numero principal e 5 numeros a ser sorteados aleatóriamente de 1 a 9.
cada numero com um valor monetario aleatório associado a ele.
caso o numero principal seja igual a 1 ou mais dos 5 numeros gerados (de 1 a 9) o prêmio é a soma dos valores associados a posição do numero igual ao numero principal sorteado.
(todos os números sorteados e valores da premiação são gerados aleatóriamente pelo sistema.)
Exemplo: número principal: 1
	1ª numero: 8 (R$100,00)
	2ª numero: 1 (R$1,00)
	3ª numero: 5 (R$1,00)
	4ª numero: 1 (R$10,00)
	5ª numero: 9 (R$100,00)
	premiação: R$11,00.
===============================================================================
RASPADINHA B: A Raspadinha de tipo B tem um custo de R$2,00 por jogo, possui um número principal e 10 números a serem sorteados aleatóriamente de 1 a 9, e um valor de prêmio
préviamente definido aleatóriamente pelo sistema, ao qual se forem sorteados 3 números ou mais iguais ao número principal, o usuário sai prêmiado.
o valor do prêmio é de 1 a 1000 reais. ao qual, se o usuário for prêmiado o valor é somado ao seu saldo.

