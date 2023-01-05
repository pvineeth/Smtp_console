using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Smtp_console
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("hello");
			SendMail(getuserName(), Password());
			Console.ReadLine();

		}
		public static void SendMail(string FromAddress, string password)
		{
			SmtpClient email = new SmtpClient
			{
				DeliveryMethod = SmtpDeliveryMethod.Network,
				UseDefaultCredentials = false,
				EnableSsl = true,
				Host = "smtp.gmail.com",
				Port = 587,
				Credentials = new NetworkCredential(FromAddress, password)

			};
			string subject = "vineeth";
			string body = $"this is vineeth body@{DateTime.UtcNow:F} this is vineeth sai ram kumar ";
			try
			{
				Console.WriteLine("Sending Email******");
				email.Send(FromAddress, ToAddress(), subject, body);
				Console.WriteLine("email sent*******");

			}
			catch (Exception ex)
			{
				Console.WriteLine(ex);
			}
		}
		public static string getuserName()
		{
			return "vineethkumarss19@gmail.com";
		}
		public static string Password()
		{
			return "ulbewbzsygapwfmf";
		}
		public static string ToAddress()
		{
			return "saivinod250@gmail.com";
		}
	}
}
