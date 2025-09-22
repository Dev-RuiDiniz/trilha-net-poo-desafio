# DIO - Trilha .NET - Programação orientada a objetos
www.dio.me

## Desafio de projeto
Para este desafio, você precisará usar seus conhecimentos adquiridos no módulo de orientação a objetos, da trilha .NET da DIO.

## Contexto
Você é responsável por modelar um sistema que trabalha com celulares. Para isso, foi solicitado que você faça uma abstração de um celular e disponibilize maneiras de diferentes marcas e modelos terem seu próprio comportamento, possibilitando um maior reuso de código e usando a orientação a objetos.

## Proposta
Você precisa criar um sistema em .NET, do tipo console, mapeando uma classe abstrata e classes específicas para dois tipos de celulares: Nokia e iPhone. 
Você deve criar as suas classes de acordo com o diagrama abaixo:

![Diagrama classes](Imagens/diagrama.png)

## Regras e validações
1. A classe **Smartphone** deve ser abstrata, não permitindo instanciar e servindo apenas como modelo.
2. A classe **Nokia** e **Iphone** devem ser classes filhas de Smartphone.
3. O método **InstalarAplicativo** deve ser sobrescrito na classe Nokia e iPhone, pois ambos possuem diferentes maneiras de instalar um aplicativo.

## Solução
O desafio foi concluído com sucesso, resultando em um programa funcional que demonstra os conceitos de **abstração**, **herança** e **polimorfismo**. Todas as regras e validações foram atendidas, com a classe abstrata `Smartphone` servindo como modelo e as classes `Nokia` e `Iphone` fornecendo implementações específicas de acordo com suas características. O projeto final inclui um arquivo de teste (`Program.cs`) que valida o comportamento de cada celular.

## Histórico de Modificações
Este registro documenta as etapas de desenvolvimento para completar o desafio de projeto.

1.  **Implementação da Classe `Smartphone`**:
    * Adição de Propriedades (`Modelo`, `IMEI`, `Memoria`).
    * Ajuste do Construtor para inicializar todas as propriedades.

2.  **Implementação da Classe `Nokia`**:
    * Herança da classe `Smartphone`.
    * Sobrescrita do método `InstalarAplicativo`.

3.  **Implementação da Classe `Iphone`**:
    * Herança da classe `Smartphone`.
    * Sobrescrita do método `InstalarAplicativo`.

4.  **Criação do Programa de Teste (`Program.cs`)**:
    * Instâncias das classes `Nokia` e `Iphone` foram criadas.
    * Testes foram realizados para validar o comportamento de cada método.