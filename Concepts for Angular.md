## 1.SPA:
Single Page Application is the web app implementation that loads only a single web document.
SPA allows users to use websites without loading whole new pages from the server.
  
## 2.JIT vs. AOT:
### JIT:
Just-in-Time(JIT) complies the app in the browser at runtime.\
JIT provides complication during the execution of the program at a run time before execution. We don't have to build projects after changing codes.\
JIT will take less compiling time.\
If the application is in local development, JIT is the bast compiler.
```
ng build
ng serve
```
### AOT:
Ahead-of-Time(AOT) complies the app at build time on the server.\
AOT can minimize the size of the application.\
We don't have to ship the HTML templates and the Angular complier whenever we enter a new component.\
AOT provides better security. It complies HTML components and templates into Javascript files long before they are served 
into the client display.
```
ng build --aot
ng serve --aot
```

## Directives vs. Pipes
### Directives
Direcctives are used to add behavior and / or modify the structure of the Document Object Model (DOM) in response to user actions or changes in application state.\
Directives can be classified into three types:\
#### 1. Structure Directives: 
they are used to define the html structure in the template. 
You can show the html element using the structure directive.  they are written with the *
```
*ngIf, *ngFor, *ngSwitch
```
#### 2. Component Directives: 
Components are a special type of directive that have their own template and can be used as standalone elements.
#### 3. Attribute Directives:
Attributes directives modify the behavior or appearance of an existing element.
```
ngClass, ngStyle, ngModel
```
### Pipes
Pipes are used for transforming data values in templates. Pipes take in an input and return a transformed output value.\
Pipes can be used to format dates, currency, and other data types. 
Pipes can also be customized to meet specific applications.
