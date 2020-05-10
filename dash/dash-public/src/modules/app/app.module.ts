import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';

import { MaterialModule } from '../material/material.module';
import { NavBarComponent } from './nav-bar/nav-bar.component';
import { NavTabsComponent } from './nav-bar/nav-tabs/nav-tabs.component';
import { PageOneComponent } from './page-one/page-one.component';
import { PageTwoComponent } from './page-two/page-two.component';
import { PageThreeComponent } from './page-three/page-three.component';
import { DragBoxComponent } from './page-two/drag-box/drag-box.component';
import { AnimalsComponent } from './page-two/animals/animals.component';
import { DragListComponent } from './page-two/drag-list/drag-list.component';

@NgModule({
  declarations: [
    AppComponent,
    NavBarComponent,
    NavTabsComponent,
    PageOneComponent,
    PageTwoComponent,
    PageThreeComponent,
    DragBoxComponent,
    AnimalsComponent,
    DragListComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    MaterialModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
