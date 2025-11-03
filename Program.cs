
using System;
using Models;

void Pause()
{
	Console.WriteLine("\nPressione Enter para voltar ao menu...");
	Console.ReadLine();
}

while (true)
{
	Console.Clear();
	Console.WriteLine("Menu de Teste - Instâncias e Métodos\n");
	Console.WriteLine("1) Carro");
	Console.WriteLine("2) Computador");
	Console.WriteLine("3) Celular");
	Console.WriteLine("4) Relógio");
	Console.WriteLine("5) Cadeira");
	Console.WriteLine("6) Televisão");
	Console.WriteLine("7) Livro");
	Console.WriteLine("8) Garrafa");
	Console.WriteLine("9) Lâmpada");
	Console.WriteLine("10) Porta");
	Console.WriteLine("11) Testar tudo");
	Console.WriteLine("0) Sair\n");
	Console.Write("Escolha uma opção: ");
	var input = Console.ReadLine();

	if (input == "0") break;

	switch (input)
	{
		case "1":
		{
			var c = new Carro("Vermelho", "Fiat", "Uno", 2005, 0, 10);
			c.Ligar();
			c.Acelerar();
			c.Acelerar();
			c.Frear();
			c.Abastecer();
			c.Desligar();
			Pause();
			break;
		}
		case "2":
		{
			var pc = new Computador("Intel i5", 8, 512, "Windows 10", false);
			pc.Ligar();
			pc.AbrirPrograma();
			pc.Reiniciar();
			pc.Atualizar();
			pc.Desligar();
			Pause();
			break;
		}
		case "3":
		{
			var tel = new Celular("Samsung", "S20", 45, "Android", "108MP");
			tel.Ligar();
			tel.TirarFoto();
			tel.FazerLigacao();
			tel.EnviarMensagem();
			tel.Carregar();
			Pause();
			break;
		}
		case "4":
		{
			var r = new Relogio("Casio", "Digital", "00:00", true);
			r.AjustarHora();
			r.MostrarHora();
			r.Cronometro();
			r.Alarme();
			Pause();
			break;
		}
		case "5":
		{
			var ch = new Cadeira("Madeira", "Marrom", 45.0, true, 120);
			ch.Girar();
			ch.AjustarAltura();
			ch.Reclinar();
			ch.Mover();
			Pause();
			break;
		}
		case "6":
		{
			var tv = new Televisao(55, "LG", "4K", 5, 10);
			tv.Ligar();
			tv.MudarCanal();
			tv.AumentarVolume();
			tv.DiminuirVolume();
			tv.Desligar();
			Pause();
			break;
		}
		case "7":
		{
			var l = new Livro("O Pequeno Príncipe", "Saint-Exupéry", "Infantil", 96, 1);
			l.Abrir();
			l.Folhear();
			l.MarcarPagina();
			l.Ler();
			l.Fechar();
			Pause();
			break;
		}
		case "8":
		{
			var g = new Garrafa("Plástico", 1.5, "Azul", false);
			g.AbrirTampa();
			g.Encher();
			g.FecharTampa();
			g.Esvaziar();
			Pause();
			break;
		}
		case "9":
		{
			var lamp = new Lampada("LED", 9, "Branco", false);
			lamp.Ligar();
			lamp.Piscar();
			lamp.Trocar();
			lamp.Desligar();
			Pause();
			break;
		}
		case "10":
		{
			var p = new Porta("Madeira", "Branca", 210, 80, false);
			p.Abrir();
			p.Trancar();
			p.Destrancar();
			p.Fechar();
			Pause();
			break;
		}
		case "11":
		{
			Console.WriteLine("Executando testes de todas as classes...\n");

			var c = new Carro("Vermelho", "Fiat", "Uno", 2005, 0, 10);
			c.Ligar(); c.Acelerar(); c.Frear(); c.Abastecer(); c.Desligar();

			var pc = new Computador("Intel i5", 8, 512, "Windows 10", false);
			pc.Ligar(); pc.AbrirPrograma(); pc.Reiniciar(); pc.Atualizar(); pc.Desligar();

			var tel = new Celular("Samsung", "S20", 45, "Android", "108MP");
			tel.Ligar(); tel.TirarFoto(); tel.FazerLigacao(); tel.EnviarMensagem(); tel.Carregar();

			var r = new Relogio("Casio", "Digital", "00:00", true);
			r.AjustarHora(); r.MostrarHora(); r.Cronometro(); r.Alarme();

			var ch = new Cadeira("Madeira", "Marrom", 45.0, true, 120);
			ch.Girar(); ch.AjustarAltura(); ch.Reclinar(); ch.Mover();

			var tv = new Televisao(55, "LG", "4K", 5, 10);
			tv.Ligar(); tv.MudarCanal(); tv.AumentarVolume(); tv.DiminuirVolume(); tv.Desligar();

			var l = new Livro("O Pequeno Príncipe", "Saint-Exupéry", "Infantil", 96, 1);
			l.Abrir(); l.Folhear(); l.MarcarPagina(); l.Ler(); l.Fechar();

			var g = new Garrafa("Plástico", 1.5, "Azul", false);
			g.AbrirTampa(); g.Encher(); g.FecharTampa(); g.Esvaziar();

			var lamp = new Lampada("LED", 9, "Branco", false);
			lamp.Ligar(); lamp.Piscar(); lamp.Trocar(); lamp.Desligar();

			var p = new Porta("Madeira", "Branca", 210, 80, false);
			p.Abrir(); p.Trancar(); p.Destrancar(); p.Fechar();

			Pause();
			break;
		}
		default:
			Console.WriteLine("Opção inválida.");
			Pause();
			break;
	}
}

Console.WriteLine("Saindo...");
