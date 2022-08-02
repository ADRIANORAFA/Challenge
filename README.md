# Desafio GitHub

Projeto ChatBot desenvolvido na plataforma da Take Blip, vinculado com a API retornando os repositórios antigos do Git Hub da Take Blip.

### 📋 Pré-requisitos
Utilizar o ngrok para criar um tunel de conexão a partir do localhost para publica-lo na internet

Api precisa estar em execução com o Ngrok para que a aba "Desafio" do BOT consiga puxar os repositórios.

### 🔧 Instalação

Execute a API e garanta que nao houve nenhum erro com a execução.

![image](https://user-images.githubusercontent.com/67528257/182432171-4bb62045-71a8-44fe-8718-366153eb2d6a.png)

Se tudo ocorrer bem, você pode testar o Andamento da API clicando no botão "Executar", que irá retornar os repositórios:

![image](https://user-images.githubusercontent.com/67528257/182432695-c60723cc-15ee-4476-826e-261ed68d2804.png)

![image](https://user-images.githubusercontent.com/67528257/182432765-8cf88ba9-891e-48c1-8420-3d6dd5299e46.png)

Para o proximo passo, abra o executavel do ngrok e digite: ngrok http https://localhost:5001 , que nos retornará o status da nossa aplicação:

![image](https://user-images.githubusercontent.com/67528257/182433499-c5ab5e2e-206e-4136-aca9-c6272120267f.png)

Após isso, vamos copiar esse endereço do Forwarding e colar em nosso navegador acrescentando o Endpoint : /Github , que nos retornará os repositórios.

![image](https://user-images.githubusercontent.com/67528257/182433847-60f28eff-c9bf-46cf-b81e-aa690e12f9cf.png)

![image](https://user-images.githubusercontent.com/67528257/182433965-46fc1f50-0237-481b-bed5-4ff5cc04ca02.png)

Feito isso, podemos ir para o nosso bot e testa- lo.
Veremos que a Aba desafio estara puxando os repositórios

![image](https://user-images.githubusercontent.com/67528257/182434257-31ef26da-8a64-4754-8949-5818330eeb90.png)


## ✒️ Autor

Adriano Rafael da Silva Alves

## 🎁 Agradecimento

Agradeço a todos pela atenção!

