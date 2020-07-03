import { HttpService } from './../http.service';
import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';


@Component({
  selector: 'app-form',
  templateUrl: './form.component.html',
  styleUrls: ['./form.component.scss']
})
export class FormComponent implements OnInit {

  isLinear = false;
  firstFormGroup: FormGroup;
  secondFormGroup: FormGroup;
  loadSubComponent = false;

  constructor(private _formBuilder: FormBuilder, private httpService: HttpService) { }

  ngOnInit(): void {
    this.firstFormGroup = this._formBuilder.group({
      firstCtrl: ['', Validators.required]
    });
    this.secondFormGroup = this._formBuilder.group({
      secondCtrl: ['', Validators.required]
    });
  }

  loadSubFormComponent()
  {
    this.loadSubComponent = true;
  }

  save()
  {
    this.httpService.getPost().subscribe(post => {
      console.log(post);
    });
  }

}

