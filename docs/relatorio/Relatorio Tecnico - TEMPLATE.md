# Informações do Projeto 

ADMINISTRAÇÃO DE FINANÇAS

-----------------------------

ENGENHARIA DE SOFTWARE

## Participantes

> Os membros do grupo são: 
> - Samuel Almeida Pinheiro 
> - Matheus Hoske Aguiar
> - Victor Fernando Marques Ribeiro
> - Lucas Garibaldi Albuqueruqe Bahia

# Estrutura do Documento

- [Informações do Projeto](#informações-do-projeto)
  - [Participantes](#participantes)
- [Estrutura do Documento](#estrutura-do-documento)
- [Introdução](#introdução)
  - [Problema](#problema)
  - [Objetivos](#objetivos)
  - [Justificativa](#justificativa)
  - [Público-Alvo](#público-alvo)
- [Especificações do Projeto](#especificações-do-projeto)
  - [Personas e Mapas de Empatia](#personas-e-mapas-de-empatia)
  - [Histórias de Usuários](#histórias-de-usuários)
  - [Requisitos](#requisitos)
    - [Requisitos Funcionais](#requisitos-funcionais)
    - [Requisitos não Funcionais](#requisitos-não-funcionais)
  - [Restrições](#restrições)
- [Projeto de Interface](#projeto-de-interface)
  - [User Flow](#user-flow)
  - [Wireframes](#wireframes)
- [Metodologia](#metodologia)
  - [Divisão de Papéis](#divisão-de-papéis)
  - [Ferramentas](#ferramentas)
  - [Controle de Versão](#controle-de-versão)
- [**############## SPRINT 1 ACABA AQUI #############**](#-sprint-1-acaba-aqui-)
- [Projeto da Solução](#projeto-da-solução)
  - [Tecnologias Utilizadas](#tecnologias-utilizadas)
  - [Arquitetura da solução](#arquitetura-da-solução)
- [Avaliação da Aplicação](#avaliação-da-aplicação)
  - [Plano de Testes](#plano-de-testes)
  - [Ferramentas de Testes (Opcional)](#ferramentas-de-testes-opcional)
  - [Registros de Testes](#registros-de-testes)
- [Referências](#referências)


# Introdução

## Problema

Um dos grandes problemas do mundo moderno é a gestão de finanças. Com os custos de vida cada vez mais elevados e a necessidade de conciliar o que fundamental com o que é luxo, varias pessoas acabam realizando uma má gestão financeira e com isso contraindo dividas e custos indesejados.

## Objetivos

Nosso principal objetivo é de ajudar os nossos usuários a equilibrarem suas finanças, melhorando a qualidade de vida dos mesmos. Acreditamos que, o quão mais equilibrada estiver a vida financeira da pessoa, melhor será sua vida pessoal.

## Justificativa

......  COLOQUE AQUI O SEU TEXTO ......

> Descreva a importância ou a motivação para trabalhar com esta aplicação
> que você escolheu. Indique as razões pelas quais você escolheu seus
> objetivos específicos ou as razões para aprofundar em certos aspectos
> do software.
> 
> O grupo de trabalho pode fazer uso de questionários, entrevistas e
> dados estatísticos, que podem ser apresentados, com o objetivo de
> esclarecer detalhes do problema que será abordado pelo grupo.
>
> **Links Úteis**:
> - [Como montar a justificativa](https://guiadamonografia.com.br/como-montar-justificativa-do-tcc/)

## Público-Alvo

Nosso público alvo consistirá em pessoas jovens e adultas que possuem no mínimo uma fonte de renda.
 
# Especificações do Projeto

Serão utilizadas as linguagens JavaScript, CSS e a framework Bootstrap para a concepção do projeto. 

## Personas e Mapas de Empatia

Com base em nossas pesquisas, conseguimos gerar as seguintes Personas: 

> ![Primeira Persona](docs/relatorio/images/Persona1.jpeg)
> ![Segunda Persona](docs/relatorio/images/Persona2.jpeg)
> ![Terceira Persona](docs/relatorio/images/Persona3.jpeg)

## Histórias de Usuários

Com base na análise das personas forma identificadas as seguintes histórias de usuários:

|EU COMO... `PERSONA` | QUERO/PRECISO ... `FUNCIONALIDADE`               |PARA ... `MOTIVO/VALOR`                                             |
|-------------------------|--------------------------------------------------|----------------------------------------------------------------|
|Usuário do sistema       | Registrar meus ganhos e gastos no app            | Ter um melhor controle sob minha vida financeira               |
|Consultor Financeiro     | Obter informações sobre movimentações do usuário | Permitir que possa ser feita uma consultoria para cada cliente |
|Administrador do Sistema | Obter informações sobre do usuário no sistema    | Consertar erros e bugs que venham a ocorrer                    |

## Requisitos

As tabelas que se seguem apresentam os requisitos funcionais e não funcionais que detalham o escopo do projeto.

### Requisitos Funcionais

|ID    | Descrição do Requisito  | Prioridade |
|------|-----------------------------------------|----|
|RF-001| Permitir que o usuário cadastre gastos e ganhos                    | ALTA | 
|RF-002| Permitir que o usuário defina metas                                | ALTA |
|RF-003| Permitir que o usuario ao cadastrar tarefa, marquea como redutivel | MÉDIA |
|RF-004| Cadastro de usuário na plataforma                                  | ALTA |
|RF-005| Definição de objetivo do usuário durante o cadastro                | MÉDIA |
|RF-006| Criar aba de investimentos                                         | BAIXA |
|RF-007| Criar aba de noticias do mercado                                   | BAIXA |


### Requisitos não Funcionais

|ID     | Descrição do Requisito  |Prioridade |
|-------|-------------------------|----|
|RNF-001| O sistema deve ser responsivo para rodar em um dispositivos móvel | ALTA | 
|RNF-002| Deve processar requisições do usuário em no máximo 3s | BAIXA | 
|RNF-003| O sistema deverá utilizar-se de banco relacional para cadastro dos usuários | MEDIA | 

## Restrições

O projeto está restrito pelos itens apresentados na tabela a seguir.

|ID| Restrição                                             |
|--|-------------------------------------------------------|
|01| O projeto deverá ser entregue até o final do semestre |
|02| Não pode ser desenvolvido um módulo de backend        |
|03| Restrito a javascript, HTML e CSS                     |
|04| Evitar alta complexidade                              |

# Projeto de Interface

|Protótipo Interativo | Figma | https://www.figma.com/file/VgyE6AaKPmRLDdE6hFSvcE/Untitled?node-id=0%3A1 |

## User Flow

> ![UserFlow](images/UserFlow.jpeg)


## Wireframes


# Metodologia

Utilizamos a metodologia do Scrum para organizar o projeto, as funções foram determinadas por consenso entre os integrantes do grupo.

## Divisão de Papéis

|Nome| Função                                     |
|---------------------------------|---------------|
|Samuel Almeida Pinheiro          | Scrum Master  |
|Matheus Hoske Aguiar             | Programador   |
|Victor Fernando Marques Ribeiro  | Designer      |
|Lucas Garibaldi Albuqueruqe Bahia| Entrevistador |

## Ferramentas

......  COLOQUE AQUI O SEU TEXTO - SIGA O EXEMPLO DA TABELA ABAIXO  ......

| Ambiente  | Plataforma              |Link de Acesso |
|-----------|-------------------------|---------------|
|Processo de Design Thinkgin  | Miro | https://miro.com/app/board/uXjVOA2Deks=/ | 
|Repositório de código | GitHub | https://github.com/ICEI-PUC-Minas-PPLES-TI/plf-es-2022-1-ti1-7946100-g9-adm-de-financas | 
|Hospedagem do site | Heroku | https://XXXXXXX.herokuapp.com (inacabado) |
|Protótipo Interativo | Figma | https://www.figma.com/file/VgyE6AaKPmRLDdE6hFSvcE/Untitled?node-id=0%3A1 | 
|Editor de código | Visual Studio Code | --- | 
|Ferramentas de comunicação | Discord | --- | 

## Controle de Versão

O controle de versão será feito a partir da plataforma GitHub, seguinte convenção para o nome de branchs:
- `master`: versão estável já testada do software
- `testing`: versão em testes do software
- `dev`: versão de desenvolvimento do software

Quanto à gerência de issues, o projeto adota a seguinte convenção para etiquetas:
- `bugfix`: uma funcionalidade encontra-se com problemas
- `enhancement`: uma funcionalidade precisa ser melhorada
- `feature`: uma nova funcionalidade precisa ser introduzida

# **############## SPRINT 1 ACABA AQUI #############**


# Projeto da Solução

......  COLOQUE AQUI O SEU TEXTO ......

## Tecnologias Utilizadas

......  COLOQUE AQUI O SEU TEXTO ......

> Descreva aqui qual(is) tecnologias você vai usar para resolver o seu
> problema, ou seja, implementar a sua solução. Liste todas as
> tecnologias envolvidas, linguagens a serem utilizadas, serviços web,
> frameworks, bibliotecas, IDEs de desenvolvimento, e ferramentas.
> Apresente também uma figura explicando como as tecnologias estão
> relacionadas ou como uma interação do usuário com o sistema vai ser
> conduzida, por onde ela passa até retornar uma resposta ao usuário.
> 
> Inclua os diagramas de User Flow, esboços criados pelo grupo
> (stoyboards), além dos protótipos de telas (wireframes). Descreva cada
> item textualmente comentando e complementando o que está apresentado
> nas imagens.

## Arquitetura da solução

......  COLOQUE AQUI O SEU TEXTO E O DIAGRAMA DE ARQUITETURA .......

> Inclua um diagrama da solução e descreva os módulos e as tecnologias
> que fazem parte da solução. Discorra sobre o diagrama.
> 
> **Exemplo do diagrama de Arquitetura**:
> 
> ![Exemplo de Arquitetura](images/arquitetura-exemplo.png)


# Avaliação da Aplicação

......  COLOQUE AQUI O SEU TEXTO ......

> Apresente os cenários de testes utilizados na realização dos testes da
> sua aplicação. Escolha cenários de testes que demonstrem os requisitos
> sendo satisfeitos.

## Plano de Testes

......  COLOQUE AQUI O SEU TEXTO ......

> Enumere quais cenários de testes foram selecionados para teste. Neste
> tópico o grupo deve detalhar quais funcionalidades avaliadas, o grupo
> de usuários que foi escolhido para participar do teste e as
> ferramentas utilizadas.
> 
> **Links Úteis**:
> - [IBM - Criação e Geração de Planos de Teste](https://www.ibm.com/developerworks/br/local/rational/criacao_geracao_planos_testes_software/index.html)
> - [Práticas e Técnicas de Testes Ágeis](http://assiste.serpro.gov.br/serproagil/Apresenta/slides.pdf)
> -  [Teste de Software: Conceitos e tipos de testes](https://blog.onedaytesting.com.br/teste-de-software/)

## Ferramentas de Testes (Opcional)

......  COLOQUE AQUI O SEU TEXTO ......

> Comente sobre as ferramentas de testes utilizadas.
> 
> **Links Úteis**:
> - [Ferramentas de Test para Java Script](https://geekflare.com/javascript-unit-testing/)
> - [UX Tools](https://uxdesign.cc/ux-user-research-and-user-testing-tools-2d339d379dc7)

## Registros de Testes

......  COLOQUE AQUI O SEU TEXTO ......

> Discorra sobre os resultados do teste. Ressaltando pontos fortes e
> fracos identificados na solução. Comente como o grupo pretende atacar
> esses pontos nas próximas iterações. Apresente as falhas detectadas e
> as melhorias geradas a partir dos resultados obtidos nos testes.


# Referências

......  COLOQUE AQUI O SEU TEXTO ......

> Inclua todas as referências (livros, artigos, sites, etc) utilizados
> no desenvolvimento do trabalho.
> 
> **Links Úteis**:
> - [Formato ABNT](https://www.normastecnicas.com/abnt/trabalhos-academicos/referencias/)
> - [Referências Bibliográficas da ABNT](https://comunidade.rockcontent.com/referencia-bibliografica-abnt/)
