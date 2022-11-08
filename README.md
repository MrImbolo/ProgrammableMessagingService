# ProgrammableMessagingService

Simple and handy command pattern implementation. 

It allows implementing any logic behind the ICommandHandler<,,> and ICommand<,,> to work with any bot source

## Building 

1. Download the source code using github tools
2. Open in your favorite IDE or code editor
3. Run dotnet build and dotnet run ProgrammableMessagingService.dll

## Implementation

1. Determine the T message and TResponse types you're gonna use

2. Implement ICommandConstructorArgs<TSource> - it'll be used a constructor arg for all the commands

3. Implement ICommandExecutionResult<TSource, TResponse, TStatus> - all command execution will have this result

4. Create a bunch of commands implementing CommandBase<TSource, TResponse, TStatus>. 
Polymorphism of commands heavily relies on constructor args. 
All required args for all the commands should be added into ICommandConstructorArgs<TSource>

5. Implement the logic of any command overriding CommandBase<TSource, TResponse, TStatus>.Execute()
and CommandBase<TSource, TResponse, TStatus>.ExecuteAsync()

6. Implement ICommandHandler<T, TResponse, TStatus> and its methods. 

7. Done. You're brilliant!