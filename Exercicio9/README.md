![Imagem Exercicio 9b](Saida.png)

Exercício 9: Controle de Estoque via Linha de Comando
Contexto:

Você é responsável por criar um pequeno sistema de gerenciamento de estoque para um comércio. O sistema rodará no terminal (linha de comando) e permitirá ao usuário inserir produtos e listar produtos cadastrados.

Manipulação de Arrays
Na primeira versão do programa, os produtos serão armazenados em um array dentro do código.

Requisitos:

✔ O programa exibe um menu de opções:
1 - Inserir Produto
2 - Listar Produtos
3 - Sair
✔ O usuário pode inserir até 5 produtos (e não mais do que 5), cada um com:
Nome
Quantidade em estoque
Preço unitário
✔ Caso o usuário escolha "Listar Produtos", o programa exibe todos os produtos cadastrados no seguinte formato:
Produto: Notebook | Quantidade: 2 | Preço: R$ 4500,00
Produto: Mouse | Quantidade: 10 | Preço: R$ 75,50
✔ Se o usuário tentar inserir mais de 5 produtos, exiba uma mensagem:
Limite de produtos atingido!
✔ O programa só encerra quando o usuário escolher "Sair".
Persistência com Arquivos
Agora, o programa armazenará os produtos em um arquivo de texto (estoque.txt), permitindo que os dados persistam após o encerramento do programa.

Requisitos adicionais:

✔ Quando o usuário escolhe "Inserir Produto", os produtos são salvos no arquivo (um por linha).
✔ Quando o usuário escolhe "Listar Produtos", o programa lê os produtos do arquivo e os exibe na tela.
✔ O arquivo deve seguir este formato:
Notebook,2,4500.00
Mouse,10,75.50
✔ Se o arquivo não existir, o programa deve criar um novo arquivo.
✔ Caso o arquivo esteja vazio, exibir a mensagem:
Nenhum produto cadastrado.
Restrições e Dicas:

Não utilize bancos de dados, apenas arrays e arquivos.
Utilize classes do .NET para manipular arquivos.
Evite sobrescrever o arquivo acidentalmente! Use AppendText para adicionar novos produtos.
Trate possíveis erros (exemplo: arquivo corrompido ou formato incorreto).
Observações:

✔ Envie uma captura de tela da saída do programa.