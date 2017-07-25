using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NormuraRuleEntties.Entities
{
	public class User
	{
		public int ID {get; set;}


		[StringLength(50)]
		public string UserID {get; set;}


		[StringLength(50)]
		public string ChtName {get; set;}


		[StringLength(50)]
		public string Password {get; set;}


		public DateTime CreateDate {get; set;}


		[StringLength(50)]
		public string IsAdmin {get; set;}


		[StringLength(50)]
		public string Remarks {get; set;}


	}

}
