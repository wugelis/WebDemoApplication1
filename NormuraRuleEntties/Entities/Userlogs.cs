using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NormuraRuleEntties.Entities
{
	public class Userlogs
	{
		public long Id {get; set;}


		[StringLength(50)]
		public string Operator {get; set;}


		[StringLength(50)]
		public string OperatorFunc {get; set;}


		public DateTime OperatorDateTime {get; set;}


		[StringLength(50)]
		public string OperatorDesc {get; set;}


		[StringLength(50)]
		public string CodeType {get; set;}


		[StringLength(50)]
		public string Action {get; set;}


	}

}
