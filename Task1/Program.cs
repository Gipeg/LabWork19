﻿using Task1;

Context context = new Context(new OperationAdd());
Console.WriteLine("10 + 5 = " + context.ExecuteSrategy(10, 5));

context = new Context(new OperationSubstract());
Console.WriteLine("10 - 5 = " + context.ExecuteSrategy(10, 5));

context = new Context(new OperationMultipy());
Console.WriteLine("10 * 5 = " + context.ExecuteSrategy(10, 5));

