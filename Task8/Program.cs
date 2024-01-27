using Task8;

Post post1 = new Post();
post1.Title = "Salom";
post1.Description = "Hama";
post1.Likecount = 0;
post1.Like();
post1.Like();
post1.Comment("Salom");
post1.Publish();
post1.Comment("Voalek");
System.Console.WriteLine(post1.Title);
System.Console.WriteLine(post1.Description);
System.Console.WriteLine(post1.Likecount);
foreach (var item in post1.comments)
{
    System.Console.WriteLine(item);
    
}
System.Console.WriteLine("***********************");


Post post2 = new Post();
post2.Title = "Salom";
post2.Description = "Hama";
post2.Likecount = 0;
post2.Like();
post2.Comment("Salom");
post2.Comment("Voalek");
System.Console.WriteLine(post2.Title);
System.Console.WriteLine(post2.Description);
System.Console.WriteLine(post2.Likecount);
foreach (var item in post2.comments)
{
    System.Console.WriteLine(item);
    
}
System.Console.WriteLine("***********************");

Post post3 = new Post();
post3.Title = "Salom";
post3.Description = "Hama";
post3.Likecount = 0;
post3.Like();
post3.Comment("Salom");
post3.Comment("Voalek");
System.Console.WriteLine(post3.Title);
System.Console.WriteLine(post3.Description);
System.Console.WriteLine(post3.Likecount);
foreach (var item in post3.comments)
{
    System.Console.WriteLine(item);
    
}
System.Console.WriteLine("***********************");


Post post4 = new Post();
post4.Title = "Salom";
post4.Description = "Hama";
post4.Likecount = 0;
post4.Like();
post4.Comment("Salom");
post4.Comment("Voalek");
System.Console.WriteLine(post4.Title);
System.Console.WriteLine(post4.Description);
System.Console.WriteLine(post4.Likecount);
foreach (var item in post4.comments)
{
    System.Console.WriteLine(item);
    
}
System.Console.WriteLine("***********************");

Post post5 = new Post();
post5.Title = "Salom";
post5.Description = "Hama";
post5.Likecount = 0;
post5.Like();
post5.Comment("Salom");
post5.Comment("Voalek");
System.Console.WriteLine(post5.Title);
System.Console.WriteLine(post5.Description);
System.Console.WriteLine(post5.Likecount);
foreach (var item in post5.comments)
{
    System.Console.WriteLine(item);
    
}
System.Console.WriteLine("***********************");



