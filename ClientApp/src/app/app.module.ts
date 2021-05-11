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
import { AutocompleteLibModule } from 'angular-ng-autocomplete';

import { AppRoutingModule } from "./app-routing.module";
import { ComponentsModule } from "./components/components.module";
import { HomeComponent } from "./home/home.component";
import { NavMenuComponent } from "./nav-menu/nav-menu.component";
import { ApiAuthorizationModule } from "../api-authorization/api-authorization.module";
import { AdminLayoutModule } from "./layouts/admin-layout/admin-layout.module";
import { BrowserModule } from "@angular/platform-browser";
import { AuthorizeGuard } from "../api-authorization/authorize.guard";
import { AuthLayoutModule } from "./layouts/auth-layout/auth-layout.module";









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
], { relativeLinkResolution: 'legacy' }),

   // AppRoutingModule,
    ToastrModule.forRoot(),
    ApiAuthorizationModule,
    AdminLayoutModule,
    AuthLayoutModule,
    BrowserModule,
    AutocompleteLibModule,
    
  ],
  declarations: [AppComponent, AdminLayoutComponent, HomeComponent, NavMenuComponent],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule {}
