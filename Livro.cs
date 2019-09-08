/*
 * Created by SharpDevelop.
 * User: THGEVER
 * Date: 07/09/2019
 * Time: 16:48
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace hjk
{
	/// <summary>
	/// Description of Livro.
	/// </summary>
	public class Livro : Biblioteca
	{
		public string Autor;
		public string NomeLivro;
		public string Gênero;
		private string ISBN {private get; private set;}
		private string SeçãoEspecial {get; private set;}
	}
}
