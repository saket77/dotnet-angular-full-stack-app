import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import {HomeComponent} from './home/home.component';
//import {LoginComponent} from './login/login.component';
import {AuthGuard} from './_services/auth-guard.service';
import {AdminComponent} from './admin/admin.component';
//import {RegisterComponent} from './register/register.component';
import { CreateComponent } from './create/create.component';
import {Role} from './_models/role';


const routes: Routes = [

						{path: '', component: HomeComponent}, 
						{path: 'create', component: CreateComponent},
						{path: 'admin', component: AdminComponent, data: { roles: [Role.admin]}},
						{ path: '**', redirectTo: '' }

					   ];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
