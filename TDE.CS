// Criando e exibindo variável idade
        int idade = 35;
        Console.WriteLine("Idade: " + idade);

        // Criando e exibindo variável nome
        string nome = "Maria";
        Console.WriteLine("Nome: " + nome);

        // Criando variável altura
        double altura = 3.45;

        // Criando constante ano e exibindo seu valor
        const int ano = 12;
        Console.WriteLine("Ano: " + ano);

        // Declarando variável nota do tipo double nullable e exibindo seu valor
        double? nota = 7.80;
        Console.WriteLine("Nota: " + nota);

        // Diferenças entre tipos por valor e tipos por referência
        // Tipos por valor: armazenam o valor diretamente na memória, enquanto os tipos por referência armazenam um endereço de memória onde o valor está localizado.

        // Nullable type é um tipo que pode ter um valor normal ou um valor nulo, útil quando um valor pode não estar presente ou ser desconhecido.

        // Camel Case é uma convenção de nomenclatura em que a primeira letra da primeira palavra é minúscula e as primeiras letras subsequentes de cada palavra são maiúsculas. Exemplo: minhaVariavel, nomeDaVariavel.

        // Pascal Case é uma convenção de nomenclatura em que a primeira letra de cada palavra é maiúscula. Exemplo: MinhaVariavel, NomeDaVariavel.

        // Declarando e inicializando variáveis x e y
        int x = 77;
        int y = 66;

        // Imprimindo a soma de x e y
        Console.WriteLine("Soma de x e y: " + (x + y));

        // Valores padrão dos tipos de dados
        bool defaultValueBool = default(bool); // false
        char defaultValueChar = default(char); // '\0'
        int defaultValueInt = default(int); // 0
        double defaultValueDouble = default(double); // 0.0
        float defaultValueFloat = default(float); // 0.0f
        decimal defaultValueDecimal = default(decimal); // 0.0m
        string defaultValueString = default(string); // null

        // Exibindo os valores padrão
        Console.WriteLine("Valores padrão:");
        Console.WriteLine("bool: " + defaultValueBool);
        Console.WriteLine("char: " + defaultValueChar);
        Console.WriteLine("int: " + defaultValueInt);
        Console.WriteLine("double: " + defaultValueDouble);
        Console.WriteLine("float: " + defaultValueFloat);
        Console.WriteLine("decimal: " + defaultValueDecimal);
        Console.WriteLine("string: " + defaultValueString);
