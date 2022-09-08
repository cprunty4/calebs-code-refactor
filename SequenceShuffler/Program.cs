// See https://aka.ms/new-console-template for more information
using SequenceShuffler;

List<President> presidents = new List<President>
{
    new President
    {
        Id = 1,
        Name = "Washington"
    },
    new President
    {
        Id = 2,
        Name = "Adams"
    },
    new President
    {
        Id=3,
        Name = "Jefferson"
    },
    new President
    {
        Id=4,
        Name = "Madison"
    },
    new President
    {
        Id=5,
        Name = "Monroe"
    }

};


var shuffler = new SequenceShuffle<President>(presidents);

while(shuffler.MoveNext())
{
    Console.WriteLine($"current = {shuffler.Current.Name} {shuffler.Current.Id}");
}


Console.ReadLine();