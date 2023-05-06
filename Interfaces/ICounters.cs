﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAndListOperations.Interfaces
{
	public interface ICounters
	{
		int WordCount(string text);

		int LetterCount(string text);

		int SpacesCount(string text);


		int FullstopCount(string text);

		int QuestionMarkCount(string text);

		int LineCount(string text);

	}
}
