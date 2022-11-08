using ProgrammableMessagingService.Default;
using ProgrammableMessagingService.Misc;

static string Read(string message)
{
    Console.Write(message);
    return Console.ReadLine()!;
}

var text = Read("Input the command>");

while(text != "/exit")
{
    var message = new CustomMessage(text, "0123456890", "09876543210", DateTime.UtcNow);

    var commandHandler = new MessageCommandHandler(new Context(), msg => msg.Text.Split(' ').First());

    var resultMessage = commandHandler.Handle(message);

    Console.WriteLine(resultMessage.Response?.Text);

    text = Read("Input the command>");
}



