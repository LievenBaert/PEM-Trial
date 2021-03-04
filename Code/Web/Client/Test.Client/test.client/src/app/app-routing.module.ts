import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { NotFoundComponent } from '@arcelormittal-platform/security';
import { ExampleComponent } from './example';

const routes: Routes = [
  { path: 'example', component: ExampleComponent },
  { path: '', redirectTo: '/example', pathMatch: 'full' },
  { path: '**', component: NotFoundComponent }
];

@NgModule({
  imports: [CommonModule, RouterModule.forRoot(routes/*, { useHash: true}*/)]
})
export class AppRoutingModule {}
