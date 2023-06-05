// Fill out your copyright notice in the Description page of Project Settings.

#pragma once

#include "CoreMinimal.h"
// REF to actor
#include "GameFramework/Actor.h"
#include "Components/StaticMeshComponent.h"
#include "TriggerEvents.generated.h"

UCLASS()
class ATriggerEvents : public AActor
{
	GENERATED_BODY()
	
	// Start 
protected:
	// Called when the game starts or when spawned
	virtual void BeginPlay() override;
	//virtual void Tick(float DeltaTime) override;

public:	
	// Sets default values for this actor's properties
	ATriggerEvents();

	UFUNCTION()
		void Event(class AActor* OverlappedActor, const class AActor* OtherActor) const;

	UPROPERTY(EditAnywhere)
		// trigger Actor
		AActor* ActorToTrigger;


	/*
public:	
	// Called every frame
	virtual void Tick(float DeltaTime) override;

	
	// Declare overlap begin function
	UFUNCTION()
	void OnOverlapBegin(class AActor* OverlappedActor, class AActor* OtherActor);

	// Declare overlap end function
	UFUNCTION()
	void OnOverlapEnd(class AActor* OverlappedActor, class AActor* OtherActor);
*/
};
