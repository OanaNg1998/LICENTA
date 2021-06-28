import { Routes } from "@angular/router";


import { IconsComponent } from "../../pages/icons/icons.component";
import { MapComponent } from "../../pages/gyms/map.component";
import { NotificationsComponent } from "../../pages/notifications/notifications.component";
import { UserComponent } from "../../pages/user/user.component";
import { TablesComponent } from "../../pages/tables/tables.component";
import { TypographyComponent } from "../../pages/typography/typography.component";
import { AdminLayoutComponent } from "./admin-layout.component";
import { AuthorizeGuard } from "../../../api-authorization/authorize.guard";
// import { RtlComponent } from "../../pages/rtl/rtl.component";


export const AdminLayoutRoutes: Routes = [
  {
    path: 'home', component: AdminLayoutComponent, children: [

      { path: '', redirectTo: 'gyms', pathMatch: 'full' },
     
      { path: "nutrition", component: IconsComponent },
      { path: "gyms", component: MapComponent },
      { path: "shoppingcart", component: NotificationsComponent },
      { path: "equipment", component: UserComponent },
      { path: "tables", component: TablesComponent },
      { path: "typography", component: TypographyComponent },
    ]
  }
  // { path: "rtl", component: RtlComponent }
];
