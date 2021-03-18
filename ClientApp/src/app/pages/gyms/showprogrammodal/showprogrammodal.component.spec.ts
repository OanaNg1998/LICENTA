import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ShowprogrammodalComponent } from './showprogrammodal.component';

describe('ShowprogrammodalComponent', () => {
  let component: ShowprogrammodalComponent;
  let fixture: ComponentFixture<ShowprogrammodalComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ShowprogrammodalComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ShowprogrammodalComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
