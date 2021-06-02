import { Component, OnInit } from '@angular/core';
import { first } from 'rxjs/operators';
import { Router, ActivatedRoute, ParamMap } from '@angular/router';
import {PArecordService} from "../_services/parecord.service";
import { Employer } from '../_models/employer';

@Component({ templateUrl: 'admin.component.html' })
export class AdminComponent implements OnInit {
  subscription;
  orderlines: Employer[];
  trackingNumber;

  //TODO: this component must show a list of registered users.

  constructor(
              private route: ActivatedRoute,
              private router: Router,
              private parecordService: PArecordService
               ) { }

  ngOnInit() {
    this.route.params.subscribe(
      params => {
        this.trackingNumber = params.trackingNumber;
      }
    );
    this.getorderlines()
   }
 getorderlines(){
    console.log(this.trackingNumber,"efvefejfewf")
    this.parecordService.get1(this.trackingNumber)
            .pipe(first())
            .subscribe(
              data => {
                  this.orderlines = data; 
              },
              error => {
              });
 }



}
