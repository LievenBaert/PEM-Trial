import { HttpClientModule } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { RouterModule } from '@angular/router';
import {
  APP_CONFIG,
  CoreModules,
  HttpTranslationConfig,
  registerLocales
} from '@arcelormittal-platform/core';
import { SecurityModules } from '@arcelormittal-platform/security';
import { UiModules } from '@arcelormittal-platform/ui';
import { TranslateModule } from '@ngx-translate/core';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { buildAppConstants } from './app.constant';
import { ExampleComponent } from './example';

@NgModule({
  declarations: [AppComponent, ExampleComponent],
  imports: [
    BrowserModule,
    BrowserAnimationsModule,
    HttpClientModule,
    CoreModules,
    UiModules,
    SecurityModules,
    RouterModule,
    AppRoutingModule,
    TranslateModule.forRoot(HttpTranslationConfig)
  ],
  providers: [{ provide: APP_CONFIG, useValue: buildAppConstants() }, registerLocales],
  bootstrap: [AppComponent]
})
export class AppModule {}
