using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NormuraRuleDBModels.Entities
{
	public class Webapiusermapping
	{
		[StringLength(50)]
		public string UserID {get; set;}


		[StringLength(50)]
		public string MethodName {get; set;}


		[StringLength(50)]
		public string RoleKey {get; set;}


		[StringLength(50)]
		public string ModuleName {get; set;}


	}

}
