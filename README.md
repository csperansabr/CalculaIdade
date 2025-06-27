> Status do Projeto: :heavy_check_mark: (concluido)

https://github.com/csperansabr/CalculaIdade?tab=readme-ov-file#-calculadora-de-idade--c-console-app

### Tópicos 
:small_blue_diamond: [Descrição do projeto](#-calculadora-de-idade--c-console-app)<br>
:small_blue_diamond: [Funcionalidades](#-funcionalidades-do-projeto)<br>
:small_blue_diamond: [Técnicas e Tecnologias Utilizadas](#%EF%B8%8F-t%C3%A9cnicas-e-tecnologias-utilizadas)<br>
:small_blue_diamond: [Como Executar](#%EF%B8%8F-como-executar)<br>
:small_blue_diamond: [Exemplos de Entrada e Saída](#-exemplos-de-entrada-e-sa%C3%ADda)<br>
:small_blue_diamond: [Boas Práticas Aplicadas](#-boas-pr%C3%A1ticas-aplicadas)<br>
:small_blue_diamond: [Estrutura Sugerida](#estrutura-sugerida)<br>
:small_blue_diamond: [Contribuições](#-contribui%C3%A7%C3%B5es)<br>
:small_blue_diamond: [Licença](#-licen%C3%A7a)<br>
:small_blue_diamond: [Acesso ao Projeto](#-acesso-ao-projeto)<br><br><br>

### 🧠 Calculadora de Idade – C# Console App
Este projeto é uma aplicação de console em C# que calcula a idade de um usuário a partir da data de nascimento fornecida, retornando o resultado em anos, meses e dias, com formatação amigável e inteligente.<br> 
A aplicação permanece em execução até que o usuário digite sair, permitindo múltiplas consultas interativas.
<br><br>
### 🔨 Funcionalidades do projeto
✅ Recebe a data de nascimento no formato dd/MM/yyyy<br>
✅ Calcula com precisão a idade em anos, meses e dias<br>
✅ Exibe somente os valores maiores que zero<br>
✅ Usa plural e singular de forma gramaticalmente correta (1 dia, 2 dias, etc.)<br>
✅ Exibe Recém-nascido se a data for o dia atual<br>
✅ Trata corretamente diferença de 1 dia<br>
✅ Mantém o programa em execução até o comando sair ser digitado<br>
✅ Valida datas inválidas ou futuras com mensagens claras<br>
<br><br>
### ✔️ Técnicas e tecnologias utilizadas
- ``C# 10+``
- ``.NET 6 ou superior``
- ``Console Application (System.Console)``
- ``System.Globalization para parsing de datas``
- ``Estrutura de controle com while, if, List<string>, TimeSpan``
<br><br>
### ▶️ Como Executar
1. Clone o repositório:
```bash
git clone https://github.com/seu-usuario/calculadora-idade-csharp.git
cd calculadora-idade-csharp
```
2. Compile e execute:
```bash
dotnet run
```
3. Digite datas no formato dd/MM/yyyy e pressione Enter.<br>
4. Digite sair para encerrar o programa.
<br><br>
### 💡 Exemplos de Entrada e Saída
| Entrada      | Saída                          |
| ------------ | ------------------------------ |
| `27/06/2025` | Idade: Recém-nascido.          |
| `26/06/2025` | Idade: 1 dia.                  |
| `27/05/2025` | Idade: 1 mês.                  |
| `26/05/2000` | Idade: 25 anos, 1 mês e 1 dia. |
| `sair`       | Programa encerrado. Até logo!  |

<br><br> 
### ✅ Boas Práticas Aplicadas
- Validação robusta de entrada
- Controle de fluxo limpo com while (true) e break
- Uso de DateTime.TryParseExact para segurança na conversão
- Separação da lógica de cálculo e formatação
- Código claro, comentado e de fácil manutenção
<br><br>
###  Estrutura Sugerida
```
calculadora-idade-csharp/
├── Program.cs
├── README.md
└── .gitignore
```
<br><br>
### 🤝 Contribuições
Contribuições são bem-vindas! Sinta-se à vontade para abrir um pull request com melhorias, ajustes ou novas funcionalidades.
<br><br>
### 📄 Licença
Este projeto está licenciado sob a [MIT License]().<br>
Copyright :copyright: 2025 - Calcula Idade
<br><br>
### 📁 Acesso ao projeto
Você pode acessar os arquivos do projeto clicando [aqui](https://github.com/csperansabr/CalculaIdade/tree/master/src).
