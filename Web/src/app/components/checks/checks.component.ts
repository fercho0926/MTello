import { Component, OnInit } from '@angular/core';
import {FormBuilder, FormControl, FormGroupDirective, NgForm, Validators} from '@angular/forms';

import {ErrorStateMatcher} from '@angular/material/core';




/** Error when invalid control is dirty, touched, or submitted. */
export class MyErrorStateMatcher implements ErrorStateMatcher {
  isErrorState(control: FormControl | null, form: FormGroupDirective | NgForm | null): boolean {
    const isSubmitted = form && form.submitted;
    return !!(control && control.invalid && (control.dirty || control.touched || isSubmitted));
  }
}



@Component({
  selector: 'app-checks',
  templateUrl: './checks.component.html',
  styleUrls: ['./checks.component.scss']
})





  export class ChecksComponent {


    selected = new FormControl('valid', [Validators.required, Validators.pattern('valid')]);

    selectFormControl = new FormControl('valid', [Validators.required, Validators.pattern('valid')]);
  
    nativeSelectFormControl = new FormControl('valid', [
      Validators.required,
      Validators.pattern('valid'),
    ]);
  
    matcher = new MyErrorStateMatcher();



    firstFormGroup = this._formBuilder.group({
      firstCtrl: ['', Validators.required],
    });
    secondFormGroup = this._formBuilder.group({
      secondCtrl: ['', Validators.required],
    });
    isEditable = false;
  
    constructor(private _formBuilder: FormBuilder) {}
  }
