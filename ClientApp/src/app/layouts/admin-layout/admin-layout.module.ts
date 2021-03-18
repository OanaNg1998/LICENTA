import { NgModule } from "@angular/core";
import { HttpClientModule } from "@angular/common/http";
import { RouterModule } from "@angular/router";
import { CommonModule } from "@angular/common";
import { FormsModule } from "@angular/forms";

import { AdminLayoutRoutes } from "./admin-layout.routing";

import { IconsComponent } from "../../pages/icons/icons.component";
import { MapComponent } from "../../pages/gyms/map.component";
import { NotificationsComponent } from "../../pages/notifications/notifications.component";
import { UserComponent } from "../../pages/user/user.component";
import { TablesComponent } from "../../pages/tables/tables.component";
import { TypographyComponent } from "../../pages/typography/typography.component";
// import { RtlComponent } from "../../pages/rtl/rtl.component";

import { NgbModule } from "@ng-bootstrap/ng-bootstrap";
import { ReactiveFormsModule } from "@angular/forms";
import { LoadingInterceptor } from "../../interceptors/loading.interceptor";
import { HTTP_INTERCEPTORS } from "@angular/common/http";
import { BrowserModule } from "@angular/platform-browser";
import { ButtonDirective } from '../../layouts/button.directive';
import { HomeComponent } from "../../home/home.component";
import { ShowprogrammodalComponent } from "../../pages/gyms/showprogrammodal/showprogrammodal.component";
import { ModalModule } from "ngx-bootstrap/modal";



@NgModule({
  imports: [
    CommonModule,
    RouterModule.forChild(AdminLayoutRoutes),
    FormsModule,
    ReactiveFormsModule,
    HttpClientModule,
    NgbModule,
    BrowserModule,
    ModalModule.forRoot(),
  

  ],
  providers:
    [{ provide: HTTP_INTERCEPTORS, useClass: LoadingInterceptor, multi: true }, HomeComponent],
  declarations: [
   
    UserComponent,
    TablesComponent,
    IconsComponent,
    TypographyComponent,
    NotificationsComponent,
    MapComponent,
    ButtonDirective,
    ShowprogrammodalComponent,
    
    // RtlComponent
  ]
})
export class AdminLayoutModule {}
