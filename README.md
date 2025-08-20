<!DOCTYPE html>
<html lang="pt-BR">
<head>
  <meta charset="UTF-8">
  <meta name="viewport" content="width=device-width, initial-scale=1.0">
  <title>Sistema de Estacionamento Inteligente</title>
  <style>
    body {
      font-family: Arial, sans-serif;
      margin: 20px;
      background: #f7f7f7;
      color: #333;
      line-height: 1.6;
    }
    h1, h2, h3 {
      color: #2c3e50;
    }
    pre {
      background: #2d2d2d;
      color: #f8f8f2;
      padding: 10px;
      border-radius: 5px;
      overflow-x: auto;
    }
    code {
      background: #ecf0f1;
      padding: 2px 5px;
      border-radius: 4px;
    }
    ul {
      margin-left: 20px;
    }
    .box {
      background: #fff;
      padding: 15px;
      margin-bottom: 20px;
      border-radius: 8px;
      box-shadow: 0 2px 6px rgba(0,0,0,0.1);
    }
    a {
      color: #2980b9;
      text-decoration: none;
    }
    a:hover {
      text-decoration: underline;
    }
  </style>
</head>
<body>

  <h1>🚗 Sistema de Estacionamento Inteligente</h1>
  <div class="box">
    <p>Um sistema de gerenciamento de estacionamento desenvolvido em <b>C# (.NET Console Application)</b>.  
    Este projeto foi inspirado em um desafio da <b>DIO</b> e expandido para simular um sistema real de uma startup de mobilidade.</p>
  </div>

  <h2>📌 Funcionalidades</h2>
  <div class="box">
    <ul>
      <li><b>Cadastro de veículos</b> com:
        <ul>
          <li>Placa</li>
          <li>Tipo do veículo (Luxo, SUV, Popular, Moto, Caminhão)</li>
          <li>Quilometragem atual</li>
          <li>Hora de entrada automática</li>
        </ul>
      </li>
      <li><b>Remoção de veículos</b>:
        <ul>
          <li>Calcula o tempo de permanência no estacionamento</li>
          <li>Aplica preços diferenciados por categoria de veículo</li>
          <li>Gera valor total a ser pago</li>
        </ul>
      </li>
      <li><b>Tabela de preços diferenciada</b>:
        <ul>
          <li>Luxo → R$ 30 inicial + R$ 15/hora</li>
          <li>SUV → R$ 20 inicial + R$ 10/hora</li>
          <li>Popular → R$ 10 inicial + R$ 5/hora</li>
          <li>Moto → R$ 5 inicial + R$ 2/hora</li>
          <li>Caminhão → R$ 40 inicial + R$ 20/hora</li>
        </ul>
      </li>
      <li><b>Listagem de veículos estacionados</b></li>
      <li><b>Histórico de veículos atendidos</b></li>
    </ul>
  </div>

  <h2>🛠️ Tecnologias utilizadas</h2>
  <div class="box">
    <ul>
      <li>C#</li>
      <li>.NET 6+ Console Application</li>
      <li>Programação orientada a objetos (POO)</li>
      <li>Estruturas de dados (<code>List</code>, <code>Dictionary</code>, <code>LINQ</code>)</li>
    </ul>
  </div>

  <h2>📂 Estrutura do projeto</h2>
  <div class="box">
    <pre>
📦 Estacionamento
 ┣ 📜 Program.cs
 ┣ 📜 Estacionamento.cs
 ┣ 📜 Veiculo.cs
 ┗ 📜 README.html
    </pre>
  </div>

  <h2>▶️ Como executar</h2>
  <div class="box">
    <h3>Pré-requisitos</h3>
    <p><a href="https://dotnet.microsoft.com/en-us/download/dotnet/6.0">.NET 6 SDK</a> ou superior instalado</p>

    <h3>Passos</h3>
    <pre>
git clone https://github.com/seu-usuario/sistema-estacionamento.git
cd sistema-estacionamento

dotnet build
dotnet run
    </pre>
  </div>

  <h2>📖 Exemplo de uso</h2>
  <div class="box">
    <h3>Menu principal</h3>
    <pre>
==== SISTEMA DE ESTACIONAMENTO ====
1 - Cadastrar veículo
2 - Remover veículo
3 - Listar veículos estacionados
4 - Listar histórico
5 - Encerrar
Escolha:
    </pre>

    <h3>Cadastro de veículo</h3>
    <pre>
Digite a placa do veículo:
ABC-1234
Digite o tipo do veículo (Luxo, SUV, Popular, Moto, Caminhao):
SUV
Digite a quilometragem atual do veículo:
54210
Veículo ABC-1234 (SUV) adicionado às 14/08/2025 15:32:10
    </pre>

    <h3>Remoção de veículo</h3>
    <pre>
Digite a placa do veículo para remover:
ABC-1234
Veículo ABC-1234 removido. Tempo: 2h. Valor a pagar: R$ 40
    </pre>
  </div>

  <h2>🚀 Melhorias futuras</h2>
  <div class="box">
    <ul>
      <li>Persistência em banco de dados (SQLite ou PostgreSQL)</li>
      <li>Relatórios financeiros mensais/anuais</li>
      <li>API REST para integração com aplicativos mobile</li>
      <li>Interface gráfica (WPF ou Web)</li>
      <li>Sistema de fidelidade para clientes</li>
    </ul>
  </div>

  <h2>👨‍💻 Autor</h2>
  <div class="box">
    <p>Desenvolvido por <b>Seu Nome</b> 🚀</p>
    <ul>
      <li>LinkedIn: <a href="https://linkedin.com/in/seu-usuario">seu-linkedin</a></li>
      <li>GitHub: <a href="https://github.com/seu-usuario">seu-usuario</a></li>
    </ul>
  </div>

</body>
</html>
