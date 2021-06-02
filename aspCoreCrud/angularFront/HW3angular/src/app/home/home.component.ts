import {Component, OnDestroy, OnInit} from '@angular/core';
import { first } from 'rxjs/operators';


import {NotificationService} from '../_services/notification.service';
import {Employee} from '../_models/employee';
import {PArecordService} from '../_services/parecord.service';


@Component({ templateUrl: 'home.component.html' ,

  styleUrls: ['home.component.css']})
export class HomeComponent implements OnInit {
  subscription;



  parecords: Employee[] = [];


  constructor(
    private parecordservice: PArecordService,
    private notifService: NotificationService
  ) {}

  ngOnInit() {
    console.log("inNgOnInit")
    this.loadAllPArecords();
      }





  private loadAllPArecords() {

    // TODO: this function should get all parecords from the server and display them. Use notification service to display messages for 'success' & 'error'.

    this.subscription = this.parecordservice.getAll().subscribe( parecord => this.foo(parecord),
      err => console.log(err)
      , () => console.log('stream end'));
  }




  private foo(parecords){


    if(parecords){
      this.parecords = parecords;
      console.log("akjebdweudvweuhlf w", this.parecords.length)
    }
    else{
      console.log(' not correct type' );
    }

    //console.log(courses);
  }

}

