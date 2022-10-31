using System;
using System.Dynamic;

namespace loteriadololo
{
	class MainClass
	{
		
			public static void Main (string[] args)
			{
				Console.ForegroundColor = ConsoleColor.Green;

				matrizvariada matrizvariada = new matrizvariada ();
				matrizatividade matrizatividade = new matrizatividade ();
				int umjogo = 0;



				int OpçãoMenu = 0;
				do {
					int opção;
					Console.WriteLine ("1 - Realizar Aposta");
					Console.WriteLine ("2 - Exibir Aposta");
					Console.WriteLine ("3 - Exibir apenas um jogo da Aposta");
					Console.WriteLine ("4 - Verificar Resultado");
					Console.WriteLine ("5 - Verificar Pontuação");
					Console.WriteLine ("6 - Sair");
					OpçãoMenu = int.Parse (Console.ReadLine ());
					switch (OpçãoMenu) {
					case 1:
						Console.WriteLine ("1- Flexível ou 2- Rígida? ");
						opção = int.Parse (Console.ReadLine ());
						if (opção == 1)
							matrizvariada.MatrizF ();
						if (opção == 2)
							matrizatividade.MatrizR ();
						break;
					case 2:
						Console.WriteLine("A aposta foi 1-flexivel ou 2-rigida?");
						int opção1 = int.Parse(Console.ReadLine());
						Console.WriteLine("");
						if(opção1==1)matrizvariada.ImprimaApostaF ();
						if(opção1==2)matrizatividade.ImprimaApostaR();
						break;
					case 3:	
matrizvariada.imprimirUmJogoF();
						break;
					case 4:

						break;
					case 5:

						break;
					case 6:
						Console.WriteLine ("Aperte <Enter> para sair");
						break;
					default:
						Console.WriteLine ("Opção inválida! Digite apenas número entre 1 e 6");
						break;
					}
				} while	((OpçãoMenu >= 1) && (OpçãoMenu <= 5));;
			}
			public void disponiveis ()
			{
				namespace loteriadololo
				{
					matrizvariada mostre = new matrizvariada();
					public disponiveis ()
					{						
					}
					public void MostrarJogo ()
					{
						Console.WriteLine ("Por favor, escolha um jogo para ser mostrado na tela.")
						int opçãodousuário = int.Parse (Console.ReadLine ());

					}

				}
			}
			public void matrizatividade ()
			{
					int[] aposta1 = new int[13];
					int[,] jogo1 = new int[13, 3];
					int[,]resultado1 = new int [13, 3];
					Random aleatoria1 = new Random ();
					int opçãousuario1;
					
					public int [] GetAposta1 ()
					{
							return aposta1;
					}

					public matrizatividade ()
					{

					}

					public void MatrizR ()
					{
							Console.WriteLine ("Faça a sua aposta, pense e digite um valor");
							Console.WriteLine ("");
							Console.WriteLine ("1- Vitória | 2- Empate | 3- Derrota ");
							Console.WriteLine ("");
							
							for (int i = 0; i < 13; i++) {
								Console.Write ("Aposta para o Jogo {0}: ", i);
								aposta1 [i] = int.Parse (Console.ReadLine ());

								if (aposta1 [i] == 1)
										jogo1 [i, 0] = 1;
								if (aposta1 [i] == 2)
										jogo1 [i, 1] = 1;
								if (aposta1 [i] == 3)
										jogo1 [i, 2] = 1;
								if (aposta1 [i] >= 4) {
										Console.WriteLine ("Essa opção não existe... Digite apenas números de 1 até 3!");
										i--;
								}
								if (aposta1 [i] <= 0) {
										Console.WriteLine ("Essa opção não existe... Digite somente números de 1 até 3!");
										i--;
								}								
							}
						{
								Console.WriteLine("");
								Console.WriteLine("Aposta rígida feita com sucesso! :v");
								Console.WriteLine("");
						}
					public void ImprimaApostaR ()
					{
						{
							Console.WriteLine("Sua cartela de pontos:");
						}
						for (int i = 0; i < 13; i++){
								for (int j = 0 j <3; j++){
										Console.Write ("{0}\t" jogo1 [i, j]);
								}

								Console.Write ("\n");
						}
						{
								Console.WriteLine("");
						}
					{
						public void imprimirUmJogoR()
						{
							{
									Console.WriteLine ("Qual é o número que deseja ver?");
									opçãousuario1 = int.Parse (Console.ReadLine ());

									if (opçãousuario1 <= -1) {
											Console.WriteLine ("Comando inválido!");
											Console.ReadLine ();
									}

									if (opçãousuario1 == 14) {
											Console.WriteLine ("Comando inválido!");
											Console.ReadLine ();
									}
							}
							Console.WriteLine (jogo1 [opçãousuario1, 0] + " " + jogo1 [opçãousuario1, 1] + " " + jogo1 [opçãousuario1, 2]);
						}
					}
					}

					}
			}
			public void matrizatividade
			{
				public int[] aposta = new int[13];
		public int[,] jogo = new int[13, 3];
		matrizatividade h= new matrizatividade();
		public int[,] resultado = new int [13, 3];
		MainClass umjoguinho=new MainClass();

		int opçãousuario;

		public int [] GetAposta ()
		{
			return aposta;
		}



		public  matrizatividade ()
		{


		}

		public void MatrizF ()
		{


			Console.WriteLine ("Faça a sua aposta");
			Console.WriteLine ("");
			Console.WriteLine ("1- Vitória | 2- Empate | 3- Derrota | 4- Vitória e Empate | 5- Derrota e Empate");
			Console.WriteLine ("");


			for (int i = 0; i < 13; i++) {

				Console.Write ("Aposta para o Jogo {0}: ", i);
				aposta [i] = int.Parse (Console.ReadLine ());


				if (aposta [i] == 1)
					jogo [i, 0] = 1;

				if (aposta [i] == 2)
					jogo [i, 1] = 1;

				if (aposta [i] == 3)
					jogo [i, 2] = 1;

				if (aposta [i] == 4) {
					jogo [i, 0] = 1;
					jogo [i, 1] = 1;
				}
				if (aposta [i] == 5) {
					jogo [i, 1] = 1;
					jogo [i, 2] = 1;
				}
				if (aposta [i] >= 6) {
					Console.WriteLine ("Opção inexistente!Digite apenas números de 1 a 3! ");
					i--;
				}
				if (aposta [i] <= 0) {
					Console.WriteLine ("Opção inexistente! Digite apenas números de 1 a 3! ");
					i--;

				}	
			}
			{
				Console.WriteLine("");
				Console.WriteLine("Aposta flexível feita com sucesso!");
				Console.WriteLine("");
			}

		}

		public void ImprimaApostaF ()
		{
			{	
				Console.WriteLine("Sua cartela:");

			}
			for (int i = 0; i < 13; i++) {
				for (int j = 0; j < 3; j++) {
					{


					}
					Console.Write ("{0}\t", jogo [i, j]);
				}

				Console.Write ("\n");

			}
			{
				Console.WriteLine("");
			}
		}
		public void  imprimirUmJogoF()
		{
			{
				
				Console.WriteLine ("A aposta foi 1-flexivel ou 2-rigida?");
			int opção2 = int.Parse (Console.ReadLine ());
				if (opção2 == 2) {
					h.imprimirUmJogoR ();
				}
				if (opção2 == 1)

			Console.WriteLine ("Qual o número do jogo que você quer ver?");
				 opçãousuario = int.Parse (Console.ReadLine ());
		}

			Console.WriteLine (jogo [opçãousuario, 0] + " " + jogo [opçãousuario, 1] + " " + jogo [opçãousuario, 2]);
				}

			}


		}
	}

