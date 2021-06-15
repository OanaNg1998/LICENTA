import { ComponentFixture, TestBed } from '@angular/core/testing';

import { NutritionfiltermodalComponent } from './nutritionfiltermodal.component';

describe('NutritionfiltermodalComponent', () => {
  let component: NutritionfiltermodalComponent;
  let fixture: ComponentFixture<NutritionfiltermodalComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ NutritionfiltermodalComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(NutritionfiltermodalComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
