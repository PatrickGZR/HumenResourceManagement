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
