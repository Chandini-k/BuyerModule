import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { BuyerdashboardComponent } from './Buyer/buyerdashboard/buyerdashboard.component';
import { SearchComponent } from './Buyer/search/search.component';


@NgModule({
  declarations: [
    AppComponent,
    BuyerdashboardComponent,
    SearchComponent

    
    
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
