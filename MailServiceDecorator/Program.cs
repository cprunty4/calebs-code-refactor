// See https://aka.ms/new-console-template for more information

Console.Title = "Decorator";

// instantiate mail service
var cloudMailService = new CloudMailService();
cloudMailService.SendMail("This is a test.");

var onPremiseMailService  = new OnPremiseMailService();

onPremiseMailService.SendMail("This is another test.");


// add behavior
var statisticsDecorator  = new StatisticsDecorator(cloudMailService);
statisticsDecorator.SendMail($"This test is via {nameof(StatisticsDecorator)} wrapper.");