IList<int> myInts = new List<int>();
myInts.Add(1);
myInts.Add(2);
myInts.Add(3);
myInts.Add(4);
myInts.Add(5);
myInts.Add(6);

var obj = myInts.Select(x=> (x* 2).ToString());

