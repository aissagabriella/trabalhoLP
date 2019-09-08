/*
 * Created by SharpDevelop.
 * User: THGEVER
 * Date: 07/09/2019
 * Time: 16:50
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace hjk
{
	/// <summary>
	/// Description of LeitorFísico.
	/// </summary>
	public class LeitorFísico : Leitor
	{
		public override void ModoLeitura()
		{
			base.ModoLeitura();
			Console.WriteLine ("O leitor optou pela leitura na forma física");
		}
	}
}
