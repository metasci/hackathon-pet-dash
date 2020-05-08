import { Component, OnInit } from '@angular/core';
import {MatSnackBar} from '@angular/material/snack-bar';

@Component({
  selector: 'nav-bar',
  templateUrl: './nav-bar.component.html',
  styleUrls: ['./nav-bar.component.css']
})
export class NavBarComponent implements OnInit {

  constructor(private _snackBar: MatSnackBar) {}

  ngOnInit(): void {
  }

  openSnackBar() {
    this._snackBar.open("Check out these settings!", "Set It", {
      duration: 2000,
    });
  }
}
