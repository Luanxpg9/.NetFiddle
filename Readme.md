# Resumo

> Vários snipets em C# para auxiliar o desenvolvimento e que podem ser úteis no futuro.
> 

---

### 1. Tratamento de string com regex

Vários snipets contem como utilizar regex e vários regex úteis.

---

### 2. Convertendo Json diretamente com Newtonsoft

O primeiro Snipet criado mostra como converter Json para Objeto e acessar seus valores diretamente sem criar DTO’s, facilitando o desenvolvimento e agilizando o processo. A única desvantagem é que o .Net não reconhece os tipos que o objeto possui, necessitando chamar diretamente.

Esse código foi desenvolvido com a necessidade de converter um Json que o C# não consegue mapear com DTO, pois o Json possuía campos $Id e Id.