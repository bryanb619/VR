// Fill out your copyright notice in the Description page of Project Settings.


#include "TriggerEvents.h"

ATriggerEvents::ATriggerEvents()
{
	OnActorBeginOverlap.AddDynamic(this, &ATriggerEvents::Event);
}

void ATriggerEvents::BeginPlay()
{
	Super::BeginPlay(); 
}

void ATriggerEvents::Event(class AActor* OverlappedActor, const class AActor* OtherActor) const
{
	// check if Actors do not equal nullptr and that 
	if (OtherActor && (OtherActor != this))
	{
		// print to screen using above defined method when actor enters trigger box
		GEngine->AddOnScreenDebugMessage(-1, 5.f, FColor::Red, FString::Printf(TEXT("Overlap Begin")));
	}
}

/*
// Sets default values
ATriggerEvents::ATriggerEvents()
{
 	// Set this actor to call Tick() every frame.  You can turn this off to improve performance if you don't need it.
	PrimaryActorTick.bCanEverTick = true;

}

// Called when the game starts or when spawned
void ATriggerEvents::BeginPlay()
{
	Super::BeginPlay();
	
}

// Called every frame
void ATriggerEvents::Tick(float DeltaTime)
{
	Super::Tick(DeltaTime);

}

*/
