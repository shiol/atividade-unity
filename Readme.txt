Projeto Final: Meu Primeiro Ambiente VR (Unity)

1. Descrição Geral
Este projeto apresenta uma experiência simples em Realidade Virtual (VR), desenvolvida na Unity, aplicando os fundamentos de XR estudados na primeira fase do curso.

2. Objetivo
Demonstrar compreensão dos conceitos básicos de XR por meio da criação de um ambiente virtual simples, navegável e coerente.

3. Escopo Implementado
- Ambiente 3D com plano de chão e skybox configurados.
- Mínimo de 5 objetos 3D posicionados de forma coerente.
- Cena testável no PC (Unity Editor/Play), sem depender exclusivamente do headset.
- Projeto preparado para build Android (Meta Quest).

4. Configuração Técnica
Versão da Unity
- Unity: 6.3 LTS

Pacotes e SDK
- Meta XR SDK instalado e configurado.
- XR Plugin Management habilitado e configurado.

Build Settings (Meta Quest)
- Platform: Android.
- Scene principal adicionada em Build Settings.
- Configurações XR ativas para execução no alvo Quest.

Execução inicial no PC
- A movimentação e testes iniciais foram realizados no Editor da Unity (Play Mode), sem necessidade do óculos VR.

5. Ambiente Virtual
- Cena contém no mínimo 5 objetos 3D (primitivos e/ou assets importados).
- Existe um plano de chão/terreno para locomoção.
- Skybox configurado para compor o ambiente.
- Elementos posicionados com lógica espacial para formar um cenário reconhecível.

6. Organização e Qualidade do Projeto
- Hierarquia de objetos organizada por grupos lógicos.
- Nomenclatura padronizada e consistente para GameObjects, cenas e assets.
- Projeto limpo, sem arquivos desnecessários.
- Estrutura de pastas principal:
  - Assets/
  - ProjectSettings/
  - Packages/

7. Como Executar no PC (Unity Editor)
1) Abrir o projeto pelo Unity Hub.
2) Abrir a cena principal em Assets/Scenes.
3) Clicar em Play para testar a navegação e interação básica.

8. Como Gerar Build para Meta Quest (Android)
1) File > Build Settings > selecionar Android > Switch Platform.
2) Confirmar cena principal em "Scenes In Build".
3) Verificar XR Plugin Management e Meta XR SDK configurados.
4) Executar Build (ou Build and Run).
