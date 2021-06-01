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
import { ScheduleclassmodalComponent } from "../../pages/gyms/showprogrammodal/scheduleclassmodal/scheduleclassmodal.component";
import { QRCodeModule } from 'angularx-qrcode';
import { FindmeasuremodalComponent } from "../../pages/user/findmeasuremodal/findmeasuremodal.component";
import { SimpleNotificationsModule } from 'angular2-notifications';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { FiltermodalComponent } from "../../pages/user/filtermodal/filtermodal.component";
import { Ng5SliderModule } from 'ng5-slider';







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
    QRCodeModule,
    SimpleNotificationsModule.forRoot(),
    BrowserAnimationsModule,
    Ng5SliderModule,
   
    
   
    
    
  

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
    ScheduleclassmodalComponent,
    FindmeasuremodalComponent,
    FiltermodalComponent
  

    
    // RtlComponent
  ],
  
})
export class AdminLayoutModule {}
