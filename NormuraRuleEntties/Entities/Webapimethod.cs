using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NormuraRuleEntties.Entities
{
	public class Webapimethod
	{
		public int ID {get; set;}


		[StringLength(50)]
		public string RoleKey {get; set;}


		[StringLength(50)]
		public string ModuleName {get; set;}


		[StringLength(50)]
		public string MethodName {get; set;}


		public DateTime CreateDate {get; set;}


		[StringLength(50)]
		public string Desc {get; set;}


	}

}
