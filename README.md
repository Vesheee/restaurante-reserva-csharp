🍽️ Restaurante-Reserva-CSharp

Um sistema simples de console desenvolvido em C# para gerenciar a reserva e o status das mesas de um restaurante. Este projeto foi criado com foco em demonstrar conceitos de Programação Orientada a Objetos (POO), como composição e separação de responsabilidades (Classes Restaurante, Mesa e Cliente).

✨ Funcionalidades

Visualização em Tempo Real: Exibe o status atual de todas as mesas.

Reservar Mesa: Permite reservar uma mesa por número, associando-a a um cliente.

Liberar Mesa: Permite liberar uma mesa para que ela volte a ficar disponível.

Validação: Verifica se o número da mesa é válido e se a mesa já está ocupada antes de reservar.

⚙️ Estrutura do Projeto (POO)

O projeto é modelado em três classes principais, seguindo o princípio da Composição:

Classe

Responsabilidade

Composição

Restaurante

Gerencia e inicializa o conjunto de mesas (Mesa[]). Responsável por buscar e exibir o status geral.

Contém um array de objetos Mesa.

Mesa

Representa uma única mesa. Responsável por seu próprio status (EstaDisponivel) e por executar as ações de Reservar e Liberar.

Contém um objeto Cliente (quando reservada).

Cliente

Armazena informações básicas do cliente (Nome).

-

🚀 Como Executar

Este projeto é um aplicativo de console C# (.NET Core/.NET 8).

Pré-requisitos

Você precisará do .NET SDK instalado em sua máquina.
