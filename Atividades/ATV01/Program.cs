//ATIVIDADE 01
using System;

Console.WriteLine("----------------------------------FICHA CADASTRAL----------------------------------");

Console.WriteLine("Olá, iremos criar sua ficha cadastral para futuras promoções da loja.");

string nome = String.Empty;
Console.WriteLine ("Qual é o seu nome?");
nome = Console.ReadLine();
string nome1 = $"Bem Vindo {nome}!";
Console.WriteLine(nome1);

string email = String.Empty;
Console.WriteLine ($"Qual é o seu email {nome}?");
email = Console.ReadLine();
string email1 = $"Seu email foi cadastrado, confirmando: {email}!";
Console.WriteLine(email1);

string data_nasc = String.Empty;
Console.WriteLine ($"Qual é a sua data de nascimento {nome}?");
data_nasc = Console.ReadLine();
string data_nasc1 = $"Sua data de nascimento é: {data_nasc}!";
Console.WriteLine(data_nasc1);

string sexo = String.Empty;
Console.WriteLine ($"Qual é o seu sexo? {sexo}");
sexo = Console.ReadLine();
string sexo1 = $"Seu sexo é: {sexo}!";
Console.WriteLine(sexo1);

Console.WriteLine("Precisaremos de informação do seu endereço.");

string cep = String.Empty;
Console.WriteLine ($"Qual é o cep da sua cidade {nome}?");
cep = Console.ReadLine();
string cep1 = $"Seu cep foi confirmado: {cep}!";
Console.WriteLine(cep1);

string cidade = String.Empty;
Console.WriteLine ($"Qual é o nome da sua cidade {nome}?");
cidade = Console.ReadLine();
string cidade1 = $"Sua cidade é: {cidade}!";
Console.WriteLine(cidade1);

string estado = String.Empty;
Console.WriteLine ($"Em que estado fica a cidade {cidade}, {nome}?");
estado = Console.ReadLine();
string estado1 = $"Seu estado é: {estado}!";
Console.WriteLine(estado);

string pais = String.Empty;
Console.WriteLine ($"Em qual país fica a cidade {cidade}, {nome}?");
pais = Console.ReadLine();
string pais1 = $"Seu pais é: {pais}, e fica localizado em {pais}";
Console.WriteLine(pais);

Console.WriteLine(@$"Confirmando sua ficha cadastral: Seu nome é {nome}.
                   Seu email é {email}.
                   Sua data de nascimento é {data_nasc}.
                   Seu sexo é: {sexo}.
                   Suas informações de endereço são: Cidade {cidade}, o seu cep é {cep} fica localizado no estado de {estado} no país {pais}.");
