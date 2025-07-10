# This is a demo application showing the use of the Command design pattern in C#.

## In this example we are using a notebook application as an example and executing the save file command.

Good software design is often based on the principle of separation of concerns, which usually results in breaking an app into layers

This allows different layers to be responsible for different functionality.

In this case layer a is the GUI layer of our app and layer b is the business logic layer.

Command objects serve as links between various layered objects. From now on, a layer a object doesn’t need to know what a layer b object will receive and how it’ll be processed. 

The layer a object just triggers the command, which handles all the details.

As a result, commands become a convenient middle layer that reduces coupling between layer a and layer b.
