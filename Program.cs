Dictionary<int, string> kullanıcılar = new Dictionary<int, string>();

kullanıcılar.Add(10, "Gökberk Perem");
kullanıcılar.Add(12, "Ayşe Perem");
kullanıcılar.Add(18, "Nilgün Erol");
kullanıcılar.Add(20, "İrfan Perem");

Console.WriteLine(kullanıcılar[10]);

Console.WriteLine("============");

foreach (var item in kullanıcılar)
{
    Console.WriteLine(item);
}

Console.WriteLine("============");

Console.WriteLine(kullanıcılar.Count);

Console.WriteLine("============");

Console.WriteLine(kullanıcılar.ContainsKey(12));
Console.WriteLine(kullanıcılar.ContainsValue("Ali Yılmaz"));

Console.WriteLine("============");

kullanıcılar.Remove(20);

foreach (var item in kullanıcılar)
{
    Console.WriteLine(item);
}