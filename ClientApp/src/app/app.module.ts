import { BrowserAnimationsModule } from "@angular/platform-browser/animations";
import { NgModule } from "@angular/core";
import { FormsModule } from "@angular/forms";
import { HttpClientModule } from "@angular/common/http";
import { RouterModule } from "@angular/router";
import { ToastrModule } from 'ngx-toastr';

import { AppComponent } from "./app.component";
import { AdminLayoutComponent } from "./layouts/admin-layout/admin-layout.component";
import { AuthLayoutComponent } from './layouts/auth-layout/auth-layout.component';

import { NgbModule } from "@ng-bootstrap/ng-bootstrap";

import { AppRoutingModule } from "./app-routing.module";
import { ComponentsModule } from "./components/components.module";
import { HomeComponent } from "./home/home.component";
import { NavMenuComponent } from "./nav-menu/nav-menu.component";
import { ApiAuthorizationModule } from "../api-authorization/api-authorization.module";
import { AdminLayoutModule } from "./layouts/admin-layout/admin-layout.module";
import { BrowserModule } from "@angular/platform-browser";
import { AuthorizeGuard } from "../api-authorization/authorize.guard";








@NgModule({
  imports: [
    BrowserAnimationsModule,
    FormsModule,
    HttpClientModule,
    ComponentsModule,
    NgbModule,
    RouterModule.forRoot([
      { path: 'login', component: HomeComponent },
      { path: 'home', component: AdminLayoutComponent, canActivate: [AuthorizeGuard] },
      { path: '', component: HomeComponent },

      //{ path: 'fetch-data', component: FetchDataComponent, canActivate: [AuthorizeGuard] },
    ]),

   // AppRoutingModule,
    ToastrModule.forRoot(),
    ApiAuthorizationModule,
    AdminLayoutModule,
    BrowserModule,
    
  ],
  declarations: [AppComponent, AdminLayoutComponent, HomeComponent, NavMenuComponent],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule {}
