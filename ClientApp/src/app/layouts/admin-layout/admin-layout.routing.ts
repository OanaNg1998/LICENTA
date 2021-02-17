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

      { path: '', redirectTo: 'icons', pathMatch: 'full' },
     
      { path: "icons", component: IconsComponent },
      { path: "maps", component: MapComponent },
      { path: "notifications", component: NotificationsComponent },
      { path: "user", component: UserComponent },
      { path: "tables", component: TablesComponent },
      { path: "typography", component: TypographyComponent },
    ]
  }
  // { path: "rtl", component: RtlComponent }
];
