# SOLID

> 🚀 SOLID é acrônimo para 5 princípios da programação orientada a objetos, que facilitam e aumentam a qualidade do desenvolvimento de softwares, com objetivo de torná-los mais fáceis de manter e estender.

### [S] Single Responsibility Principle (Princípio da responsabilidade única)
- Cada classe deve ter sua própria responsabilidade.
- Uma classe deve ter um, e somente um, motivo para mudar.

### [O] Open-Closed Principle (Princípio Aberto-Fechado)
- Permite estender o código sem quebrar funcionalidades já existentes.
- Uma classe deve ser fechada para modificações e aberta para extensões.
- Aberto para extensão significa que uma classe pode utilizar de herança para extender o código.
- Fechada para modificação significa que super classes não devem sofrer alterações em funcionalidade existentes pois podem afetar as classes filhas.
- Exemplos de aplicação do princípio OCP são através de herança e interfaces.

### [L] Liskov Substitution Principle (Princípio da substituição de Liskov)
- Uma classe derivada deve ser substituível pela sua classe base.
- Introduzido por Barbara Liskov em 1987.

### [I] Interface Segregation Principle (Princípio da segregação da Interface)
- Importante evitar interfaces infladas, ou seja com muitos métodos.
- Os clientes não devem ser obrigados a implementar métodos que eles não utilizem.
- A ideia de interface pode ser aplicada também a classes abstratas.
- Reforça os princípios [S] e [L].

### [D] Dependency Inversion Principle (Princípio da inversão da dependência)
- Um módulo de alto nível não pode depender de um módulo de baixo nível, ambos devem depender da abstação.
- Os módulos de alto nível são as regras de negócio que a aplicação resolve.
- Os módulos de baixo nível são as tarefas realizadas pela aplicação, parte interna.
- Exemplo: Alto nível: Classe Product (Regras de negócio), baixo nível: Classe Database (comunicação com o banco de dados).

### 😎 Autor

Guilherme Ferrari - guile.ferrari@hotmail.com

[![Linkedin Badge](https://img.shields.io/badge/-Guilherme-blue?style=flat-square&logo=Linkedin&logoColor=white&link=https://www.linkedin.com/in/guilherme-antonio-ferrari/)](https://www.linkedin.com/in/guilherme-antonio-ferrari/)

### 🎯 Contribuição

1. Faça o _fork_ do projeto
2. Crie uma _branch_ para sua modificação (`git checkout -b feature/descricaoFeature`)
3. Faça o _commit_ (`git commit -am 'Add descricaoFeature'`)
4. _Push_ (`git push origin feature/descricaoFeature`)
5. Crie um novo _Pull Request_

### 📝 Licença

MIT.