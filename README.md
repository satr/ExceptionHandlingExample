ExceptionHandlingExample
========================

Exception Handling Example: how to handle different levels of error for internal components, plugins, WCF service

The project contains:
1. App - WPF Application
- Settings dialog - works with business logic of the App. 
- Book list with add new book dialog = works with WCF Service as a source (see below).
- Buttons which invoke methods of Internal Component and plugins (see below).
- Two independent log lists which filter log entries by severity.
2. Internal Component which App is referenced directly:
- Component has methods which work correct or throws exceptions of different severity.
3. Plugins which App is loaded dynamically:
- Each plugin throws an exception of different severity.
4. WCF Service which App uses as remote source:
- Service has methods which work correct or throw exceptions of different severity.
- Exceptions are wrapped by FaultException and passed over network connection.
