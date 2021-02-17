import { Injectable, Injector } from '@angular/core';
import { HttpInterceptor, HttpRequest, HttpHandler, HttpEvent } from '@angular/common/http';
import { Observable } from 'rxjs';
import { LoaderService } from '../services/loader.service';
import { delay, finalize } from 'rxjs/operators';

@Injectable()
export class LoadingInterceptor implements HttpInterceptor {
  constructor(private injector: Injector) { }
  intercept(
    req: HttpRequest<any>,
    next: HttpHandler
  ): Observable<HttpEvent<any>> {
    if (!req.url.includes("User")) {
      return next.handle(req);
    }

    const loaderService = this.injector.get(LoaderService);

    loaderService.show();

    return next.handle(req).pipe(
      delay(1000),
      finalize(() => loaderService.hide())
    );
  }
}
