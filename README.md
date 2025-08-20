<!DOCTYPE html>
<html lang="pt-BR">
<head>
  <meta charset="UTF-8">
  <meta name="viewport" content="width=device-width, initial-scale=1.0">
  <h1>Sistema de Estacionamento Inteligente</h1>
  
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
    
git clone https://github.com/seu-usuario/sistema-estacionamento.git
cd sistema-estacionamento

dotnet build
dotnet run

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
    <p>Desenvolvido por <b>Alisson Guilherme Gonçalves Ramos</b> 🚀</p>
    <ul>
      <li>LinkedIn: <a href="https://www.linkedin.com/in/alisson-ramos-6b137b2b8" target="_blank">Conecte-se comigo no LinkedIn 🚀</a></li>
      <li>GitHub: <a href="https://github.com/AlissonGGR" target="_blank">Confira meus projetos no GitHub 💻</a></li>
    </ul>
  </div>

</body>
</html>
