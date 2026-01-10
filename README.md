# ARcheology

ARcheology é um projeto de Realidade Aumentada (AR) desenvolvido em Unity, com o objetivo de criar uma experiência interativa e educativa sobre arqueologia. Utilizando o AR Foundation, o projeto permite que usuários explorem artefatos virtuais, interajam com objetos 3D e realizem ações como escanear, segurar e guardar itens em armários virtuais. Ele foi criado como parte do meu aprendizado na **trilha de desenvolvimento AR do Instituto de pesquisa Eldorado na NexVisual**, sendo o criador original do projeto **Victor Vasconcelos**, este é apenas o espelho do meu projeto que fiz durante a trilha.

## Funcionalidades

- **Detecção de planos AR**: Utiliza AR Foundation para identificar superfícies reais onde a experiência pode ser iniciada.
- **Interação com objetos**: Os usuários podem tocar em artefatos para pegar, soltar, escanear e visualizar informações detalhadas.
- **Animações e feedback visual**: Objetos possuem animações e painéis informativos que aparecem conforme a interação.
- **Gerenciamento de spots e armários**: Artefatos podem ser guardados em spots específicos ou armários virtuais.

## Estrutura do Código

O projeto está organizado em scripts C# que controlam a lógica de interação e o fluxo da experiência AR:

- `InitialSetup.cs`: Gerencia a detecção de planos e o início da experiência AR.
- `StartExperience.cs`: Instancia a cena principal sobre o plano detectado e anima os objetos.
- `ObjectInteractor.cs`: Controla a lógica de interação dos artefatos (pegar, soltar, mostrar informações).
- `HoldingManager.cs`: Gerencia o objeto atualmente segurado pelo usuário.
- `ScannerController.cs`: Permite escanear artefatos, desbloqueando informações após um tempo.
- `CabinetController.cs` e `SpotController.cs`: Gerenciam o armazenamento de artefatos em spots e armários.
- `ObjectInfoController.cs`: Exibe informações detalhadas sobre cada artefato.
- `InputHandler.cs`: Realiza raycast para detectar toques e interações.
- `Billboard.cs`: Garante que textos informativos estejam sempre voltados para a câmera.

## Tecnologias Utilizadas

- Unity 3D
- AR Foundation
- C#
- TextMesh Pro

## Como rodar o projeto

1. Abra o projeto no Unity (versão recomendada: 2021.3 ou superior).
2. Certifique-se de que o AR Foundation está instalado e configurado para seu dispositivo.
3. Conecte um dispositivo compatível com AR (Android/iOS) e faça o build.
4. Siga as instruções na tela para iniciar a experiência AR.

## Screenshots

<img width="948" height="451" alt="Captura de Tela 2026-01-10 às 01 07 53" src="https://github.com/user-attachments/assets/8b822dc7-7493-45b5-950e-6783931b9037" />

